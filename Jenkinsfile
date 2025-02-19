pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.0' // Use .NET 6.0.0
    }

    stages {
        // Checkout code from the repository
        stage('Checkout Code') {
            steps {
                checkout scm
            }
        }

        // Setup .NET SDK
        stage('Setup .NET') {
            steps {
                script {
                    // Install .NET SDK 6.0.0 (for Windows)
                    bat 'curl -SL https://aka.ms/install-dotnet-preview -o dotnet-installer.exe'
                    bat 'dotnet-installer.exe /quiet /norestart'
                }
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

        // Optionally, you can archive test results or publish reports
        stage('Publish Test Results') {
            steps {
                junit '**/test_results.trx' // Publish the test results (Jenkins will show them)
            }
        }
    }

    // Trigger actions on failure or success
    post {
        always {
            steps {
                echo "Cleaning up after build."
            }
        }

        success {
            echo "Build and tests passed successfully!"
        }

        failure {
            echo "Build or tests failed. Please check the logs!"
        }
    }
}
