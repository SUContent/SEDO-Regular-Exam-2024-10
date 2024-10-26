pipeline {
    agent any 
    stages {
        stage('Restore dependencies') { 
            steps {
                bat 'dotnet restore'
            }
        }
        stage('Dotnet build') { 
            steps {
                bat 'dotnet build --no-restore'
            }
        }
        stage('Execute the tests') { 
            steps {
                bat 'donet build --no-build --verbosity normal'
            }
        }
    }
}
