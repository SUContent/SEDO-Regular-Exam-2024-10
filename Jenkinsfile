pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm  // Check out the source code from the repository
            }
        }

        stage('Build') {
            steps {
                script {
                    sh 'dotnet build --configuration Release'  // Build the application
                }
            }
        }

        stage('Run Unit Tests') {
            steps {
                script {
                    sh 'dotnet test --no-restore --verbosity normal'  // Run the unit tests
                }
            }
        }
    }

    post {
        always {
            junit '**/TestResults/*.xml'  // Publish test results, adjust the path accordingly
        }
        success {
            echo 'Build and tests completed successfully.'
        }
        failure {
            echo 'Build or tests failed. Check the logs for details.'
        }
    }
}
