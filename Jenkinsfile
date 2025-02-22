pipeline {
    agent any
  
    stages {
        stage('Build and Run Tests') {
            steps {
                script {
                    bat 'dotnet restore'
                    bat 'dotnet build --no-restore'
                    bat 'dotnet test --no-build --verbosity normal'
                }
            }
        }
    }
}
