// This pipeline is meant to be run locally
pipeline {
    agent any
    
    stages {
        stage ("Restore project dependencies") {
            steps {
                bat 'dotnet restore'
            }
        }
    
        stage ("Build app") {
            steps {
              bat 'dotnet build --no-restore'
            }
        }
    
        stage ("Run all tests") {
            steps {
              bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
