pipeline {
    agent any
    
    stages {
        
        stage('Restore dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }
        
        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }
        
        stage('Run integration tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
