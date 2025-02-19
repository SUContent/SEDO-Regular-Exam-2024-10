pipeline {
    agent any

    stages {
        stage("Build") {
            steps {
                bat "dotnet build --verbosity normal"
            }
        }
        stage("Restore dependencies") {
            steps {
                bat "dotnet restore --verbosity normal"
            }
        }
        stage("Test") {
            steps {
                bat "dotnet test --no-build --verbosity normal"
            }
        }
    }
    post {
        always { echo "CI completed" }
        success { echo "Build and test successfully" }
        failure { echo "Build or tests failed" }
    }
}
