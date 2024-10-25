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
                bat 'dotnet tests  --no-build --verbosity normal'
            }
        }
    }
}
