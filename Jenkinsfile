pipeline {
    agent any
    stages {
         stage('Restore dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }
        stage('Build app') {
            steps {
                bat 'dotnet build'
            }
        }
        stage('Run tests') {
            steps {
                bat 'dotnet test'
            }
        }
    }
}
