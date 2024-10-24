pipeline {
    agent any 
    stages {
        stage('Restore dependencies') { 
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build') { 
            steps {
                sh 'dotnet build --no-restore' 
            }
        }
        stage('Test') { 
            steps {
                sh 'dotnet test --no-build --verbosity normal' 
            }
        }
    }
}
