pipeline {
    agent any

    stages {        
        stage('Restore .NET') {
            steps {
                bat 'dotnet restore'
            }
        }
        stage('Build Solution') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }
        stage('Perform All Tests') {
            steps {
                bat 'dotnet test --verbosity quiet'
            }
        }
        
    }
}
