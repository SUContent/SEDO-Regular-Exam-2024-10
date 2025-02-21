pipeline {
    agent any
    
    stages {

        stage('Restore dependencies') {
            steps {
                // Restore the project dependencies
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Build the project without restoring the dependencies again
                bat 'dotnet build --no-restore'
            }
        }

        stage('Test') {
            steps {
                // Run tests for the specified project
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
