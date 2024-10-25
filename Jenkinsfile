pipeline {
    agent any  // Use an appropriate Jenkins agent label


    environment {
        DOTNET_VERSION = '8.0.x'
    }

        stage('Setup .NET') {
            steps {
                // Install .NET SDK
                sh "curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version $DOTNET_VERSION"
                // Add .NET to PATH
                sh 'export PATH="$HOME/.dotnet:$PATH"'
            }
        }

        stage('Restore dependencies') {
            steps {
                // Restore .NET dependencies
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Build the project
                sh 'dotnet build --no-restore'
            }
        }

        stage('Test') {
            steps {
                // Run tests
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }

}
