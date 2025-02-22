pipeline {
    agent any

    environment {
        DOTNET_VERSION = "6.0.x"
    }

    stages {
        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Run Tests') {
            steps {
                sh 'dotnet test  --no-build --verbosity normal'
            }
        }
    }
}
