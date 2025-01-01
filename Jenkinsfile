pipeline {
    agent any

    stages {
        stage('Restore dependecies') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Dotnet build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }
        stage('Run tests') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
