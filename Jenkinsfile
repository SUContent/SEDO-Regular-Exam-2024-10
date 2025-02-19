pipeline {
    agent any

    stages {
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

        stage('Run tests') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
