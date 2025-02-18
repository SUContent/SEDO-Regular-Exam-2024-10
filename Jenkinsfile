pipeline {
    agent any
    environment {
        DOTNET_ROOT = "/usr/local/share/dotnet"
        PATH = "$DOTNET_ROOT:$PATH"
    }
    stages {
        stage('Restore dependencies') {
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
