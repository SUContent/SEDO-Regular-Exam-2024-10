pipeline {
    agent any

    stages {
        stage('Checkout code') {
            steps {
                // Checkout the code from the repository
                git url: 'https://github.com/enevmartin/SEDO-Regular-Exam-2024-10', branch: 'feature-ci-pipeline'
            }
        }

        stage('Debug Branch Name') {
            steps {
                script {
                    echo "Current branch: ${env.BRANCH_NAME}"
                }
            }
        }

        stage('Set up .NET') {
            steps {
                script {
                    // Assuming the environment variable 'DOTNET_VERSION' is set to '6.0.x'
                    def dotnetVersion = '6.0.x'
                    sh "dotnet --version" // Verify the version before proceeding
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
                    return env.BRANCH_NAME in ['develop', 'feature-ci-pipeline'] 
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
