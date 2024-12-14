pipeline {
    agent any
    stages {
        stage('Build Solution & Run All Test') {
            steps {
                bat 'dotnet restore'
                bat 'dotnet build --no-restore'
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}