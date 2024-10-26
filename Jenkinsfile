pipeline {
    agent any

    when {
        branch "master"
    }
    stages {
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