pipeline {
    agent any 
    stages {
        stage('Restore dependencies') { 
            steps {
                script {
                    bat "dotnet restore"
                }
            }
        }
        stage('Dotnet build') { 
            steps {
                script {
                    bat "dotnet build --no-restore"
                }
            }
        }
        stage('Execute tests') { 
            steps {
                script {
                    bat "dotnet test --no-build --verbosity normal"
                }
            }
        }
    }
    
}
