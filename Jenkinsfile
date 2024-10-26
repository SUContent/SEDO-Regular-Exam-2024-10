pipeline {
    agent any

    stages {
        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj --no-build --verbosity normal'
            }
        }
    }
}
