# Release Flow

[![Run Build and Test](https://github.com/kolosovpetro/ReleaseFlow/actions/workflows/run-build-and-test.yml/badge.svg)](https://github.com/kolosovpetro/ReleaseFlow/actions/workflows/run-build-and-test.yml)

In this demo project a GitFlow release approach is shown where Semantic Versioning is a part of CI/CD pipeline.

### Release strategy

See also [Atlassian Docs GitFlow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)

- Checkout from `develop` to `release/{x.x.x}` branch, where `{x.x.x}` is a semantic version number
- Final release updates like minor bugfixes, documentation updates are done to `release/{x.x.x}` branch
- Deployments to `dev` environment run automatically from branches: `release/*` and `develop`
- Deployments to `qa` environment run automatically from branches: `release/*` and `develop` with **manual approval**
- When release is ready, there is a pull request from `release/{x.x.x}` branch to `master` branch
- When pull request from `release/{x.x.x}` to `master` is merged, a new `tag {x.x.x}` is created and pushed
- After `tag {x.x.x}` is pushed a new deployment to `prod` environment is started manually from `master` branch
    - `git tag -a v0.1.0 -m "my version 0.1.0"`
    - `git tag -d <tag_name>`
    - `git push origin <tag_name>`
    - `git push --delete origin tagname`
- When release is ready, there is a pull request from `release/{x.x.x}` branch to `develop` branch
- When pull request from `release/{x.x.x}` to `develop` is merged there is automatic deployment to `dev`
- When pull request from `release/{x.x.x}` to `develop` is merged there is automatic deployment to `qa` with **manual
  approval**

## Sources

- [Atlassian GitFlow Documentation](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)