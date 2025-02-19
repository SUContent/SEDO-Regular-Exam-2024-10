pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.0' // Use .NET 6.0.0
    }

    triggers {
        // Trigger on changes pushed to any branch
        // This will trigger the pipeline for any new branch pushed
        gitHubPush()
    }

    stages {
        // Checkout code from the repository
        stage('Checkout Code') {
            steps {
                checkout scm
            }
        }

        // Restore dependencies
        stage('Restore Dependencies') {
            steps {
                script {
                    // Run dotnet restore
                    bat 'dotnet restore'
                }
            }
        }

        // Build the application
        stage('Build Application') {
            steps {
                script {
                    // Run dotnet build
                    bat 'dotnet build --no-restore'
                }
            }
        }

        // Run tests
        stage('Run Tests') {
            steps {
                script {
                    // Run dotnet test with test results logging
                    bat 'dotnet test --no-build --logger "trx;LogFileName=test_results.trx"'
                }
            }
        }
    }

    // Actions on success or failure
    post {
        always {
            echo 'Cleaning up after build.'
        }

        success {
            echo 'Build and tests passed successfully!'
        }

        failure {
            echo 'Build or tests failed. Please check the logs!'
        }
    }
}
