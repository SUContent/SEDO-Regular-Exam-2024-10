properties([
    pipelineTriggers([[$class: 'GitHubPushTrigger']])
])

node {
        stage('Define env variables'){
        env.GIT_BRANCH = 'refs/heads/feature-ci-pipeline' 
        env.PATH_TO_PROJECT_FILE = "C:\\Users\\jenkins\\Documents\\SEDO-Regular-Exam-2024-10\\HouseRentingSystem.sln"
        env.PATH_TO_UNIT_TESTS = "C:\\Users\\jenkins\\Documents\\SEDO-Regular-Exam-2024-10\\HouseRentingSystem.UnitTests\\HouseRentingSystem.UnitTests.csproj"
        env.PATH_TO_INTEGRATION_TESTS = "C:\\Users\\jenkins\\Documents\\SEDO-Regular-Exam-2024-10\\HouseRentingSystem.Tests\\HouseRentingSystem.Tests.csproj"
        }

        stage('Clean Working Space') {
            cleanWs()
        }

        stage('Restore Project Packages') {
            bat "dotnet restore %PATH_TO_PROJECT_FILE%"
            echo "Package restore done!"
        }

        stage('Run Both Integration and Unit Tests') {
            bat """
            dotnet test \"%PATH_TO_UNIT_TESTS%\" --configuration Release
            dotnet test \"%PATH_TO_INTEGRATION_TESTS%\" --configuration Release
            echo Tests completed!
            """
        }
}
