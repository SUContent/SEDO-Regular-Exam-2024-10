pipeline {
    agent any

    stages {
        stage('Restore Dependencies') {
            steps {
                script {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    bat 'dotnet build --configuration Release'
                }
            }
        }

        stage('Run Tests') {
            steps {
                script {
                    bat 'dotnet test --configuration Release --no-build'
                }
            }
        }

    }
}
