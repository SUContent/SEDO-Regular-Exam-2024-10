pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore dependencies') {
            steps {
                bat '"C:/Program Files/dotnet/dotnet.exe" restore'
            }
        }

        stage('Build') {
            steps {
                bat '"C:/Program Files/dotnet/dotnet.exe" build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                bat '"C:/Program Files/dotnet/dotnet.exe" test --no-build'
            }
        }
    }
}
