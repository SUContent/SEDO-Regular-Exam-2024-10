pipeline {
    agent any

    stages {

        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
               
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
