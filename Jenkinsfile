pipeline {
    agent any

    stages {
        when {
            branch "feature-ci-pipeline"
        }
        stage("Run pipeline") {
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