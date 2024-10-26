pipeline {
    agent any

    stages {
        if (env.BRANCH_NAME == "feature-ci-pipeline") {
            stage("Restore dependencies") {
                steps {
                    bat "dotnet restore"
                }
            }
            stage("Build") {
                steps {
                    bat "dotnet build --no-restore"
                }
            }
            stage("Test") {
                steps {
                    bat "dotnet test --no-build --verbosity quiet"
                }
            }
        }
    }
}