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

        // Install Chocolatey
        stage('Install Chocolatey') {
            steps {
                script {
                    // Install Chocolatey if not already installed (only needed if you haven't installed it yet)
                    bat 'Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString("https://community.chocolatey.org/install.ps1"))'
                }
            }
        }

        // Install .NET SDK using Chocolatey
        stage('Setup .NET SDK') {
            steps {
                script {
                    // Install .NET SDK via Chocolatey
                    bat 'choco install dotnet-sdk --version=6.0.0 -y'
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
