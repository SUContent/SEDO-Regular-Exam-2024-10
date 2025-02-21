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
                        sh 'curl -SL https://download.visualstudio.microsoft.com/download/pr/abdb2bb2-d256-4624-8e87-d5fe362711b4/68b3f7b8c6a44e60f2892a6a64b07cd2/dotnet-sdk-6.0.100-linux-x64.tar.gz'
                        sh 'tar -xvf dotnet-sdk-6.0.100-linux-x64.tar.gz'
                        sh 'sudo mv dotnet /usr/local/bin'
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
