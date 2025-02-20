pipeline {
    agent any

    stages {
         stage('Install wget') {
            steps {
                sh 'sudo apt-get update && sudo apt-get install -y wget'
            }
        }

        stage('Setup .NET') {
            steps {
                sh 'wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh'
                sh 'chmod +x dotnet-install.sh'
                sh './dotnet-install.sh --version 6.0.0'
                sh 'export PATH="$HOME/.dotnet:$PATH"'
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
}






