pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x'
    }

    stages {
        stage('Checkout Repository') {
            steps {
                checkout scm
            }
        }

        stage('Install .NET SDK') {
            steps {
                script {
                    if (!fileExists('/usr/local/bin/dotnet')) {
                        echo 'Installing .NET SDK...'
                        
                        sh '''
                            curl -SL https://download.visualstudio.microsoft.com/download/pr/87f2e678-b4d0-42bc-b351-6262c513d071/7c245c7582c0935778a50d6f69bfa8d2/dotnet-sdk-6.0.100-linux-x64.tar.gz -o dotnet-sdk-6.0.100-linux-x64.tar.gz
                            file dotnet-sdk-6.0.100-linux-x64.tar.gz  # Check the file type
                        '''
                        
                        sh 'if ! file dotnet-sdk-6.0.100-linux-x64.tar.gz | grep -q "gzip compressed data"; then exit 1; fi'

                        sh 'tar -xvf dotnet-sdk-6.0.100-linux-x64.tar.gz'
                        sh 'mv dotnet /usr/local/bin'

                        sh 'rm dotnet-sdk-6.0.100-linux-x64.tar.gz'
                    }
                }
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }

    post {
        always {
            cleanWs()
        }
    }
}
