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

        // 

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

        //
