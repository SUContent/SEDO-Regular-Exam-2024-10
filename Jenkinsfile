pipeline {
    agent any 
    stages {
        stage('Build') { 
            steps {
               bat:'dotnet build'
            }
        }
        stage('Test') { 
            steps {
                bat: 'dotnet test'
            }
        }
    }
}
