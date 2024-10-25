pipeline {
    agent any
      stages {
        stage('Restore dependencies') {
            steps {
                // Restore .NET dependencies
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --no-restore'
            }
        }

        stage('Execute Tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
