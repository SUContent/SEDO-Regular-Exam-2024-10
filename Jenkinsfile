pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x'
    }

    stages {
        stage('Restore Dependencies') {
            steps {
                // Restore the project dependencies
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Build the project
                bat 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                // Run the unit tests
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
