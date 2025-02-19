pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x' // Define .NET version
    }

    stages {
        stage('Checkout Repository') {
            steps {
                script {
                    echo 'Checking out the repository...'
                }
                checkout scm
            }
        }

        stage('Set up .NET Core') {
            steps {
                script {
                    echo 'Setting up .NET Core SDK...'
                }
                bat 'dotnet --version' // Ensure .NET is installed
            }
        }

        stage('Restore Dependencies') {
            steps {
                script {
                    echo 'Restoring dependencies...'
                }
                bat 'dotnet restore HouseRentingSystem.sln'
            }
        }

        stage('Build') {
            steps {
                script {
                    echo 'Building the solution...'
                }
                bat 'dotnet build HouseRentingSystem.sln --no-restore'
            }
        }

        stage('Run Tests in Parallel') {
            parallel {
                stage('Run Unit Tests in Parallel') {
                    steps {
                        script {
                    echo 'Running Unit Tests...'
                }
                bat 'dotnet test HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj --no-build --verbosity normal'
            }
                }
                stage('Run Integration Tests in Parallel') {
                    steps {
                        script {
                    echo 'Running Integration Tests...'
                }
                bat 'dotnet test HouseRentingSystem.Tests/HouseRentingSystem.Tests.csproj --no-build --verbosity normal'
                }
                }
            }
        }
    }

    post {
        success {
            echo 'Pipeline executed successfully!'
        }
        failure {
            echo 'Pipeline failed. Check logs for details.'
        }
    }
}
