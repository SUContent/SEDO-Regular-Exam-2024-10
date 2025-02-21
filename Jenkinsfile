pipeline {
    agent any
    stages {
        stage('Build solution') {
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
