pipeline {
    agent any
    environment {
        PATH = "/usr/local/share/dotnet:/usr/local/bin:/usr/bin:/bin:/usr/sbin:/sbin"
    }
    stages {
        stage('Restore dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build Project') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }
        stage('Run dotnet tests') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}