pipeline {
    agent any 

    stages {
        stage("Restore") {
            steps {
                sh 'dotnet restore'
            }
        }

        stage("Build") {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage("Run Tests") {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }

}