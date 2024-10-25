pipeline {
    agent any

    stages {
        stage('Checkout code') {
            steps {
                // Checkout the code from the public repository
                git url: 'https://github.com/enevmartin/SEDO-Regular-Exam-2024-10.git', branch: 'feature-ci-pipeline'
            }
        }

        stage('Set up .NET') {
            steps {
                script {
                    // Set up .NET SDK version (Make sure .NET SDK is installed in Jenkins container)
                    sh 'dotnet --version' // Verify the installed .NET version
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
                    // Run unit tests only on the 'feature-ci-pipeline' branch
                    return env.BRANCH_NAME == 'feature-ci-pipeline' 
                }
            }
            steps {
                // Run unit tests
                sh 'dotnet test --no-restore --verbosity normal'
            }
        }
    }
}
