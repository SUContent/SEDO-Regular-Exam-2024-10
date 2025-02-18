pipeline {
    agent any

        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }
        
        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }
        
        stage('Run Unit Tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
