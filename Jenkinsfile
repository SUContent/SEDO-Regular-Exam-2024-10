// This pipeline is meant to be run locally (on the machine, currently testing the code)
pipeline {
    agent any
    
    stages {
        stage('Restore project dependencies') {
            steps {
                bat 'dotnet restore'
            }
        }
    
        stage('Build app') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }
    
        stage('Run all tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }

        stage('Print message') {
            steps {
                echo 'Pipeline completed! :)'
            }
        }
    }
}
