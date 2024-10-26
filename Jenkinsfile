pipeline {
    agent any

    stages {
        stage('Verify dotnet') {
            steps {
                bat 'dotnet --version'
            }
        }
        stage('Restore dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }
        stage('Build project') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }
        stage('Execute tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
