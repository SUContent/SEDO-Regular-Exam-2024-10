pipeline {
    agent any

    environment {
        DOTNET_VERSION = "6.0.x"
    }

    stages {
        stage('Setup .NET') {
            steps {
                script {
                    sh "wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh"
                    sh "chmod +x dotnet-install.sh"
                    sh "./dotnet-install.sh --version \"${DOTNET_VERSION}\" --install-dir \"/usr/share/dotnet\""
                    sh "export PATH=\"/usr/share/dotnet:\$PATH\""
                }
            }
        }

        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
