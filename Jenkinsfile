pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm // Checkout the code from the repository
            }
        }

        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet test --verbosity normal'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}

