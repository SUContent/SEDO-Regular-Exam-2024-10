pipeline{
    agent any
    stages{
        stage("Build")
        {
            steps{
                bat 'dotnet build'
            }
        }
          stage("Run tests")
        {
            steps{
                bat 'dotnet tests C:\Users\lasss\Desktop\ExamPRep\HouseRentingSystem.UnitTests --no-build --verbosity normal'
            }
        }
    }
}