pipeline {
    agent any
    triggers {
        pollSCM('* * * * *')
    }

    stages {
        when {
            branch 'feature-ci-pipeline'
        }
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

        stage('Test') {
            steps {
                bat 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
