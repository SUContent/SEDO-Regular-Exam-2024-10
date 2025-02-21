pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                sh 'dotnet restore HouseRentingSystem.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build HouseRentingSystem.sln --configuration Release --no-restore'
            }
        }

        stage('Test') {
            parallel {
                stage('Unit Tests') {
                    steps {
                        sh 'dotnet test HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj --no-build'
                    }
                }
                stage('Integration Tests') {
                    steps {
                        sh 'dotnet test HouseRentingSystem.Tests/HouseRentingSystem.Tests.csproj --no-build'
                    }
                }
            }
        }
    }

    post {
        always {
            cleanWs()
        }
    }
}