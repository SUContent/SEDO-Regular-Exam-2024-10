pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0.x'
        PROJECT_PATH = 'HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj'
    }

    stages {

        stage('Restore Dependencies') {
            steps {
                script {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    bat 'dotnet build --no-restore'
                }
            }
        }

        stage('Run Unit Tests') {
            steps {
                script {
                    sh "dotnet test --no-build --verbosity normal"
                }
            }
        }
    }
}
