pipeline {
    agent any

    stages {
        stage('Checkout code') {
            steps {
                // Checkout the code from the repository
                git url: 'https://github.com/enevmartin/SEDO-Regular-Exam-2024-10', branch: 'feature-ci-pipeline'
            }
        }

        stage('Set up .NET') {
            steps {
                // Set up .NET SDK version
                script {
                    // Assuming the environment variable 'DOTNET_VERSION' is set to '6.0.x'
                    def dotnetVersion = '6.0.x'
                    sh "dotnet --version" // This is to verify the version before proceeding
                }
            }
        }

        stage('Restore dependencies') {
            steps {
                // Restore the dependencies
                sh 'dotnet restore'
            }
        }

        stage('Build the application') {
            steps {
                // Build the application
                sh 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Unit Tests') {
            when {
                expression { 
                    // Run unit tests only on the 'develop' branch
                    return env.BRANCH_NAME == 'develop' 
                }
            }
            steps {
                // Restore dependencies for unit tests
                sh 'dotnet restore'
                
                // Run unit tests
                sh 'dotnet test --no-restore --verbosity normal'
            }
        }

        stage('Integration Tests') {
            when {
                expression { 
                    // Run integration tests only on the 'staging' branch
                    return env.BRANCH_NAME == 'staging' 
                }
            }
            steps {
                // Restore dependencies for integration tests
                sh 'dotnet restore'

                // Run integration tests
                sh 'dotnet test --no-restore --verbosity normal --filter "Category=Integration"'
            }
        }
    }
}
