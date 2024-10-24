pipeline {
    agent any 
    stages {
       stage('Restore the project') { 
            steps {
                sh 'dotnet restore' 
            }
        }
        stage('Build the project') { 
            steps {
                 sh 'dotnet build'
            }
        }
        stage('Test the project') { 
            steps {
                sh 'dotnet test --no-build' 
            }
        }
    }
}
