pipeline {
    agent any

    stages {
        stage('Setup .NET') {
            steps {
                sh '''
                # Install .NET SDK via Homebrew
                brew update
                brew install dotnet
                export PATH="/usr/local/share/dotnet:$PATH"
                '''
            }
        }

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
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}




