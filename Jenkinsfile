pipeline {
    agent any
    environment {
        DOTNET_VERSION = '6.0.0'
    }
    stages {
        stage('Setup .NET') {
            steps {
                script {
                    sh 'curl -fsSL https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh'
                    sh 'chmod +x dotnet-install.sh'
                    sh './dotnet-install.sh --version $DOTNET_VERSION'
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
                sh 'dotnet build'
            }
        }
        stage('Run Tests') {
            steps {
                sh 'dotnet test'
            }
        }
    }
}





