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
                    // Install .NET SDK 6.0.0 (for Linux as an example, adjust as needed for other OS)
                    sh 'wget https://download.visualstudio.microsoft.com/download/pr/64b6990e-b2d3-4029-b17c-4e4ea02c0e19/090a0b428553fc50506cd5cf54031a62/dotnet-sdk-6.0.0-linux-x64.tar.gz'
                    sh 'mkdir -p $HOME/dotnet && tar zxf dotnet-sdk-6.0.0-linux-x64.tar.gz -C $HOME/dotnet'
                    sh 'export PATH=$HOME/dotnet:$PATH'
                }
            }
        }

        // Restore dependencies
        stage('Restore Dependencies') {
            steps {
                script {
                    // Run dotnet restore
                    sh 'dotnet restore'
                }
            }
        }

        // Build the application
        stage('Build Application') {
            steps {
                script {
                    // Run dotnet build
                    sh 'dotnet build --no-restore'
                }
            }
        }

        // Run tests
        stage('Run Tests') {
            steps {
                script {
                    // Run dotnet test with test results logging
                    sh 'dotnet test --no-build --logger "trx;LogFileName=test_results.trx"'
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
