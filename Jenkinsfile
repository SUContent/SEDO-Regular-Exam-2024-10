pipeline {
    agent any 

    stages {
     

        stage('Restore dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Dotnet Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Execute Unit and Integration Tests') {
            steps {
                bat 'dotnet test HouseRentingSystem.UnitTests/HouseRentingSystem.UnitTests.csproj --no-build --verbosity normal'
                bat 'dotnet test HouseRentingSystem.Tests/HouseRentingSystem.Tests.csproj --no-build --verbosity normal'
            }
        }
       
    }

    
}
