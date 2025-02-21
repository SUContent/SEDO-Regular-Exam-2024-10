pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x'
    }

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

    post {
        always {
            // This block runs after the pipeline finishes, no matter the result
            echo 'Cleaning up...'
        }
    }
}
