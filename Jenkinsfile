pipeline {
    agent any

    stages {
         stage('Restore') {
            steps {
                script {
                    docker.image('mcr.microsoft.com/dotnet/sdk:6.0').inside {
                        sh 'dotnet restore'
                    }
                }
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