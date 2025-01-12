pipeline {
    agent any
    stages {
        stage('Restore dependancy') {
            steps {
                bat 'dotnet restore'
            }
        }
        stage('Dotnet Build') {
            steps {
                bat 'dotnet biuld'
            }
        }
        stage('Dotnet Test') {
            steps {
                bat 'dotnet test'
            }
        }
    }
}
