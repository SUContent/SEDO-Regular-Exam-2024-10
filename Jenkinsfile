pipeline {
    agent { label 'ubuntu-latest' }

    triggers {
        pollSCM('H/5 * * * *')
    }

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/victoriagopin/SEDO-Regular-Exam-2025-02' // Change branch and URL
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

    post {
        always {
            junit '**/TestResults/*.xml'
        }
    }
}

